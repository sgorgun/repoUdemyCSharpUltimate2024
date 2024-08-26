using System;

namespace Coding.Exercise
{
    public class SortedList<T> where T : IComparable<T>
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }

    public class FullName : IComparable<FullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public override string ToString() => $"{FirstName} {LastName}";

        public int CompareTo(FullName other)
        {
            if (other == null) return 1;

            // Compare by last name

            int lastNameColmparsion = this.LastName.CompareTo(other.LastName);

            if (lastNameColmparsion != 0)
            {
                return lastNameColmparsion;
            }

            // if last names are same, compare by first name

            return this.FirstName.CompareTo(other.FirstName);
        }
    }
}