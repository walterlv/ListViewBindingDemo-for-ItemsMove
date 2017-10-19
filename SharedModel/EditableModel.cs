using System.Collections.Generic;
using Walterlv.ComponentModel;

namespace Walterlv
{
    public class EditableModel : NotificationObject, IEqualityComparer<EditableModel>
    {
        public EditableModel(string initialText)
        {
            _editingText = initialText;
        }

        private string _editingText;

        public string EditingText
        {
            get => _editingText;
            set => SetValue(ref _editingText, value);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EditableModel model)) return false;
            return Equals(this, model);
        }

        public override int GetHashCode()
        {
            return GetHashCode(this);
        }

        public bool Equals(EditableModel x, EditableModel y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return string.Equals(x._editingText, y._editingText);
        }

        public int GetHashCode(EditableModel obj)
        {
            return (obj._editingText != null ? obj._editingText.GetHashCode() : 0);
        }

        public static implicit operator EditableModel(string editingText)
        {
            return new EditableModel(editingText);
        }

        public static explicit operator string(EditableModel model)
        {
            return model._editingText;
        }
    }
}
