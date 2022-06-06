namespace MetalUp.FunctionalLibrary
{
    public class Range : FList<int>
    {
        internal Range(int first, int last, int step) : base(first, null)
        {
            Step = step;
            Last = last;
        }

        private int Step;

        private int Last;

        internal override FList<int> Tail
        {
            get {
                return Head + Step > Last ? null : 
                                            new Range(Head+Step, Last, Step);
            }
        }

        public override string ToString()
        {
            string second = Step == 1 ? "" : $",{(Head + Step).ToString()}";
            string end = Last == int.MaxValue ? "" : Last.ToString();
            return $"{Head}{second}..{end}";
        }
    }
}
