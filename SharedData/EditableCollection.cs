using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Walterlv;

namespace SharedData
{
    internal class EditableViewModel
    {
        public ObservableCollection<EditableModel> EditableCollection { get; } =
            new ObservableCollection<EditableModel>
            {
                new EditableModel("A"),
                new EditableModel("B"),
                new EditableModel("C"),
                new EditableModel("D"),
                new EditableModel("E"),
                new EditableModel("F"),
                new EditableModel("G"),
                new EditableModel("H"),
                new EditableModel("I"),
                new EditableModel("J"),
            };

        internal async void RunChangingOrder()
        {
            var random = new Random(DateTime.Now.Ticks.GetHashCode());
            for (var i = 0; i < 1000; i++)
            {
                await Task.Delay(2000);
                var index = EditableCollection.IndexOf("E");
                EditableCollection.Move(
                    index,
                    random.Next(EditableCollection.Count));
            }
        }
    }
}
