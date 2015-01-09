﻿using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konamiman.NestorMSX.Hardware;
using Konamiman.NestorMSX.Host;
using Konamiman.NestorMSX.Misc;
using Konamiman.Z80dotNet;

namespace Konamiman.NestorMSX.Emulator
{
    /// <summary>
    /// Full environment for running a MSX emulation.
    /// </summary>
    public class MsxEmulationEnvironment
    {
        private const int BDOS = 0xFB03;    //as defined in dskbasic.mac

        private DosFunctionCallExecutor dosFunctionsExecutor;
        private MsxEmulator emulator;
        private IKeyEventSource keyboardEventSource;
        private EmulatorHostForm form;

        public MsxEmulationEnvironment(Configuration config)
        {
            var z80 = CreateCpu(config);

            var slots = CreateSlotsSystem(config);
            z80.Memory = slots;
            
            form = CreateHostForm(config, z80);
            keyboardEventSource = form;

            var vdp = CreateVdp(config, form);
            z80.RegisterInterruptSource(vdp);
            form.Vdp = vdp;

            var keyboard = CreateKeyboardController(config, form);
            
            ConfigureDiskRom(config, slots, z80);
            
            var hardware = new MsxHardwareSet {
                Cpu = z80,
                KeyboardController = keyboard,
                SlotsSystem = slots,
                Vdp = vdp
            };

            emulator = new MsxEmulator(hardware);
        }

        private void ConfigureDiskRom(Configuration config, IExternallyControlledSlotsSystem slots, IZ80Processor z80)
        {
            if(config.DiskRomFile != null) {
                slots.SetSlotContents(1, new PlainRom(File.ReadAllBytes(config.DiskRomFile.AsAbsolutePath()), 1));
                z80.BeforeInstructionFetch += Z80OnBeforeInstructionFetch;
                dosFunctionsExecutor = new DosFunctionCallExecutor(z80.Registers, slots, config);
            }
        }

        private KeyboardController CreateKeyboardController(Configuration config, IKeyEventSource keyEventSource)
        {
            return new KeyboardController(keyEventSource, File.ReadAllText(config.KeymapFile));
        }

        private IExternallyControlledTms9918 CreateVdp(Configuration config, IDrawingSurface drawingSurface)
        {
            return new Tms9918(new DisplayRenderer(new GraphicsBasedDisplay(drawingSurface, config), config), config);
        }

        private EmulatorHostForm CreateHostForm(Configuration config, IZ80Processor cpu)
        {
            return new EmulatorHostForm(cpu, config);
        }

        private IExternallyControlledSlotsSystem CreateSlotsSystem(Configuration config)
        {
            var slots = new SlotsSystem();

            slots.SetSlotContents(0, new PlainRom(File.ReadAllBytes(config.BiosFile)));

            if(config.Slot2RomFile != null)
                slots.SetSlotContents(2, new PlainRom(File.ReadAllBytes(config.Slot2RomFile.AsAbsolutePath()), 1));

            var ram = new PlainMemory(ushort.MaxValue + 1);
            slots.SetSlotContents(3, ram);

            return slots;
        }

        private IZ80Processor CreateCpu(Configuration config)
        {
            var z80 = new Z80Processor();

            if(config.CpuSpeedInMHz == 0)
                z80.ClockSynchronizer = null;
            else
                z80.ClockFrequencyInMHz = config.CpuSpeedInMHz;

            return z80;
        }

        private void Z80OnBeforeInstructionFetch(object sender, BeforeInstructionFetchEventArgs eventArgs)
        {
            if(((IZ80Processor)sender).Registers.PC == BDOS)
            {
                dosFunctionsExecutor.ExecuteFunctionCall();
            }
        }

        public void Run()
        {
            keyboardEventSource.StartGeneratingKeyEvents();
            Task.Run(() => emulator.Run());
            Application.Run(form);
        }
    }
}
