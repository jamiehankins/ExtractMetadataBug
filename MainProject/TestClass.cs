using System;

namespace MainProject
{
    /// <summary>
    /// This is a test class to have something for DocFX to document.
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// This is a constructor to document.
        /// </summary>
        public TestClass() { }

        public string DoDad { get; }

        /// <summary>
        /// Simple method to generate docs for.
        /// </summary>
        /// <remarks>
        /// I'd like to take a moment to thank all of those who helped me get to
        /// a place where I can write documentation like this.
        /// </remarks>
        /// <param name="source">A meaningless boolean value, much like most questions in the world.</param>
        /// <returns>An exactly equivalently meaningless boolean value, much like most answers in the world.</returns>
        public bool BoolReturningMethod(bool source) { SupportLibrary.SupportClass.DoNothing(source); return source; }
    }
}
