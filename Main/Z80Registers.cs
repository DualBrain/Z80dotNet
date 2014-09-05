﻿namespace Konamiman.Z80dotNet
{
    /// <summary>
    /// Represents a full set of Z80 registers.
    /// </summary>
    public class Z80Registers : IZ80Registers
    {
        public IMainZ80Registers Main { get; set; }

        public IMainZ80Registers Alternate { get; set; }

        public short IX { get; set; }

        public short IY { get; set; }

        public short PC { get; set; }

        public short SP { get; set; }

        public short IR { get; set; }

#if false
        private byte _IM;
        /// <summary>
        /// The current interrupt mode register. It has always the value 0, 1 or 2.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Attempt to set a value other than 0, 1 or 2</exception>
        public byte IM
        {
            get
            {
                return _IM;
            }
            set
            {
                if(value > 2)
                    throw new InvalidOperationException("IM can be set to 0, 1 or 2 only");

                _IM = value;
            }
        }
#endif

        public Bit IFF1 { get; set; }

        public Bit IFF2 { get; set; }

        public byte IXh
        {
            get
            {
                return IX.GetHighByte();
            }
            set
            {
                IX = IX.SetHighByte(value);
            }
        }

        public byte IXl
        {
            get
            {
                return IX.GetLowByte();
            }
            set
            {
                IX = IX.SetLowByte(value);
            }
        }

        public byte IYh
        {
            get
            {
                return IY.GetHighByte();
            }
            set
            {
                IY = IY.SetHighByte(value);
            }
        }

        public byte IYl
        {
            get
            {
                return IY.GetLowByte();
            }
            set
            {
                IY = IY.SetLowByte(value);
            }
        }

        public byte I
        {
            get
            {
                return IR.GetHighByte();
            }
            set
            {
                IR = IR.SetHighByte(value);
            }
        }

        public byte R
        {
            get
            {
                return IR.GetLowByte();
            }
            set
            {
                IR = IR.SetLowByte(value);
            }
        }
    }
}