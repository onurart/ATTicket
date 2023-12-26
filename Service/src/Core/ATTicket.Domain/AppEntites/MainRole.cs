namespace ATTicket.Domain.AppEntites
{
    public sealed class MainRole : Entity
    {
        public MainRole()
        {

        }
        public MainRole(string id, string title, bool isRoleCreatedByAdmin = false) : base(id)
        {
            Title = title;
            IsRoleCreatedByAdmin = isRoleCreatedByAdmin;
        }
        public string Title { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }

    }
}
