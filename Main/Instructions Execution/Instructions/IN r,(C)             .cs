﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "IN r,(C)             .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The IN A,(C) instruction.
        /// </summary>
        byte IN_A_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.A = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN B,(C) instruction.
        /// </summary>
        byte IN_B_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.B = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN C,(C) instruction.
        /// </summary>
        byte IN_C_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.C = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN D,(C) instruction.
        /// </summary>
        byte IN_D_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.D = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN E,(C) instruction.
        /// </summary>
        byte IN_E_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.E = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN H,(C) instruction.
        /// </summary>
        byte IN_H_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.H = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN L,(C) instruction.
        /// </summary>
        byte IN_L_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);
            Registers.L = value;

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

        /// <summary>
        /// The IN F,(C) instruction.
        /// </summary>
        byte IN_F_C()
        {
            FetchFinished();

            var value = ProcessorAgent.ReadFromPort(Registers.C);

            Registers.SF = value.GetBit(7);
            Registers.ZF = (value == 0);
            Registers.NF = 0;
            Registers.HF = 0;
            Registers.PF = Parity[value];
            SetFlags3and5From(value);

            return 12;
        }

    }
}