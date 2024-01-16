using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ThumbColorNotReset.ViewModels.Messages
{
    public class SelectedViewChangedMessage : ValueChangedMessage<byte>
    {
        public SelectedViewChangedMessage(byte selectedViewIndex) : base(selectedViewIndex)
        {
            
        }
    }
}
