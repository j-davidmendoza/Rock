namespace Rock.ViewModels.Rest.Controls
{

    /// <summary>
    /// The options that can be passed to the GroupPickerGetAllGroups API action of
    /// the GroupsPicker control.
    /// </summary>
    public class GroupPickerGetAllGroupsOptionsBag
    {
        /// <summary>
        /// Whether to include inactive groups or not.
        /// </summary>
        public bool IncludeInactiveGroups { get; set; } = false;
    }
}
