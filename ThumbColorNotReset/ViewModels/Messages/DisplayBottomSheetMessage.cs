using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ThumbColorNotReset.ViewModels.Messages
{
    public class DisplayBottomSheetMessage : ValueChangedMessage<bool>
    {
        public DisplayBottomSheetMessage(bool value) : base(value)
        {
            
        }
    }
}
