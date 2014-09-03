namespace Konamiman.Z80dotNet
{
    /// <summary>
    /// Represents a reason for the processor not being running.
    /// </summary>
    public enum StopReason
    {
        /// <summary>
        /// The processor is currently running, so no stop reason applies.
        /// </summary>
        NotApplicable,

        /// <summary>
        /// The processor has never been running since it was instantiated.
        /// </summary>
        NeverRan,

        /// <summary>
        /// The processor was running and finished with an invocation of <see cref="IZ80Processor.Stop"/>
        /// with <c>isPause=false</c>.
        /// </summary>
        StopInvoked,

        /// <summary>
        /// The processor was running and finished with an invocation of <see cref="IZ80Processor.Stop"/>
        /// with <c>isPause=true</c>.
        /// </summary>
        PauseInvoked,

        /// <summary>
        /// The <see cref="IZ80Processor.ExecuteNextInstruction"/> was invoked and finished normally
        /// (the <see cref="IZ80Processor.Stop"/> method was not invoked).
        /// </summary>
        ExecuteNextInstructionInvoked,

        /// <summary>
        /// A HALT instruction was encountered when interrupts were disabled,
        /// and <see cref="IZ80Processor.AutoStopOnDiPlusHalt"/> was set to true.
        /// </summary>
        DiPlusHalt
    }
}