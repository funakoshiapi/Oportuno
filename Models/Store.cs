namespace Oportuno.Models
{
    public partial class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email {get; set;}
        public string Phone {get; set;}
        public string Adress {get; set;}
        public string Image {get; set;}
        public ServiceType StoreService{get; set;}
    }

}