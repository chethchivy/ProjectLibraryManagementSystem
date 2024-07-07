namespace ProjectLibraryManagementSystem.Model
{
    public class ComboBoxItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ComboBoxItem(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
