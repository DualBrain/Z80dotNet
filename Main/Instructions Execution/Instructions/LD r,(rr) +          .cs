﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "LD r,(rr) +          .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LD A,(BC) instruction.
        /// </summary>
        byte LD_A_aBC()
        {
		    FetchFinished();

			var address = (ushort)Registers.BC;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.A = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (BC),A instruction.
        /// </summary>
        byte LD_aBC_A()
        {
		    FetchFinished();

	        var newValue = Registers.A;
			var address = (ushort)Registers.BC;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD A,(DE) instruction.
        /// </summary>
        byte LD_A_aDE()
        {
		    FetchFinished();

			var address = (ushort)Registers.DE;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.A = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (DE),A instruction.
        /// </summary>
        byte LD_aDE_A()
        {
		    FetchFinished();

	        var newValue = Registers.A;
			var address = (ushort)Registers.DE;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD A,(HL) instruction.
        /// </summary>
        byte LD_A_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.A = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),A instruction.
        /// </summary>
        byte LD_aHL_A()
        {
		    FetchFinished();

	        var newValue = Registers.A;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD B,(HL) instruction.
        /// </summary>
        byte LD_B_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.B = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),B instruction.
        /// </summary>
        byte LD_aHL_B()
        {
		    FetchFinished();

	        var newValue = Registers.B;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD C,(HL) instruction.
        /// </summary>
        byte LD_C_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.C = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),C instruction.
        /// </summary>
        byte LD_aHL_C()
        {
		    FetchFinished();

	        var newValue = Registers.C;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD D,(HL) instruction.
        /// </summary>
        byte LD_D_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.D = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),D instruction.
        /// </summary>
        byte LD_aHL_D()
        {
		    FetchFinished();

	        var newValue = Registers.D;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD E,(HL) instruction.
        /// </summary>
        byte LD_E_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.E = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),E instruction.
        /// </summary>
        byte LD_aHL_E()
        {
		    FetchFinished();

	        var newValue = Registers.E;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD H,(HL) instruction.
        /// </summary>
        byte LD_H_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.H = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),H instruction.
        /// </summary>
        byte LD_aHL_H()
        {
		    FetchFinished();

	        var newValue = Registers.H;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD L,(HL) instruction.
        /// </summary>
        byte LD_L_aHL()
        {
		    FetchFinished();

			var address = (ushort)Registers.HL;
			var oldValue = ProcessorAgent.ReadFromMemory(address);
    	    Registers.L = oldValue;

            return 7;
        }

        /// <summary>
        /// The LD (HL),L instruction.
        /// </summary>
        byte LD_aHL_L()
        {
		    FetchFinished();

	        var newValue = Registers.L;
			var address = (ushort)Registers.HL;
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 7;
        }

        /// <summary>
        /// The LD A,(IX+n) instruction.
        /// </summary>
        byte LD_A_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.A = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),A instruction.
        /// </summary>
        byte LD_aIX_plus_n_A()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.A;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD B,(IX+n) instruction.
        /// </summary>
        byte LD_B_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.B = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),B instruction.
        /// </summary>
        byte LD_aIX_plus_n_B()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.B;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD C,(IX+n) instruction.
        /// </summary>
        byte LD_C_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.C = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),C instruction.
        /// </summary>
        byte LD_aIX_plus_n_C()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.C;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD D,(IX+n) instruction.
        /// </summary>
        byte LD_D_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.D = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),D instruction.
        /// </summary>
        byte LD_aIX_plus_n_D()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.D;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD E,(IX+n) instruction.
        /// </summary>
        byte LD_E_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.E = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),E instruction.
        /// </summary>
        byte LD_aIX_plus_n_E()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.E;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD H,(IX+n) instruction.
        /// </summary>
        byte LD_H_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.H = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),H instruction.
        /// </summary>
        byte LD_aIX_plus_n_H()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.H;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD L,(IX+n) instruction.
        /// </summary>
        byte LD_L_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IX + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.L = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IX+n),L instruction.
        /// </summary>
        byte LD_aIX_plus_n_L()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.L;
			var address = (ushort)(Registers.IX + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD A,(IY+n) instruction.
        /// </summary>
        byte LD_A_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.A = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),A instruction.
        /// </summary>
        byte LD_aIY_plus_n_A()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.A;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD B,(IY+n) instruction.
        /// </summary>
        byte LD_B_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.B = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),B instruction.
        /// </summary>
        byte LD_aIY_plus_n_B()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.B;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD C,(IY+n) instruction.
        /// </summary>
        byte LD_C_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.C = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),C instruction.
        /// </summary>
        byte LD_aIY_plus_n_C()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.C;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD D,(IY+n) instruction.
        /// </summary>
        byte LD_D_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.D = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),D instruction.
        /// </summary>
        byte LD_aIY_plus_n_D()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.D;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD E,(IY+n) instruction.
        /// </summary>
        byte LD_E_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.E = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),E instruction.
        /// </summary>
        byte LD_aIY_plus_n_E()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.E;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD H,(IY+n) instruction.
        /// </summary>
        byte LD_H_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.H = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),H instruction.
        /// </summary>
        byte LD_aIY_plus_n_H()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.H;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD L,(IY+n) instruction.
        /// </summary>
        byte LD_L_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

			var address = (ushort)(Registers.IY + (SByte)offset);
			var oldValue = ProcessorAgent.ReadFromMemory(address);
		    Registers.L = oldValue;

            return 19;
        }

        /// <summary>
        /// The LD (IY+n),L instruction.
        /// </summary>
        byte LD_aIY_plus_n_L()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
		    FetchFinished();

	        var newValue = Registers.L;
			var address = (ushort)(Registers.IY + (SByte)offset);
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

    }
}
