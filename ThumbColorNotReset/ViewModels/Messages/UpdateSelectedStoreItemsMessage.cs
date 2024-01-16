using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ThumbColorNotReset.ViewModels.Messages
{
    public class UpdateSelectedStoreItemsMessage : ValueChangedMessage<bool>
    {
        public UpdateSelectedStoreItemsMessage(bool value) : base(value)
        {
            
        }
    }
}
