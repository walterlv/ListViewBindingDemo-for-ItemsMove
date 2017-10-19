using Walterlv.ComponentModel;

namespace Walterlv
{
    public class EditableModel : NotificationObject
    {
        private string _editingText;

        public string EditingText
        {
            get => _editingText;
            set => SetValue(ref _editingText, value);
        }
    }
}
