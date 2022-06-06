namespace MetalUp.FunctionalLibrary
{
    public class FList<T> where T : IEquatable
    {


        internal FList(T head, FList<T> tail)
        {
            Head = head;
            Tail = tail;
        }

        internal T Head { get; private set; }
        internal virtual FList<T> Tail { get; private set; }

        public override string ToString()
        {
            return Tail == null ?
                            Head.ToString()
                            : typeof(char).IsAssignableFrom(typeof(T)) ?
                                Head.ToString() + Tail.ToString()
                                : Head + ", " + Tail;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (!(obj is FList<T>))
            {
                return false;
            }
            else if (!Head.Equals((obj as FList<T>).Head))
            {
                return false;
            }
            else if (Tail != null)
            {
                return Tail.Equals((obj as FList<T>).Tail);
            }
            else  // Heads are equal but this.Tail is null
            {
                return (obj as FList<T>).Tail == null;
            }
        }

        public override int GetHashCode()
        {
            return Head.GetHashCode() + Tail.GetHashCode();
        }
    }
}
