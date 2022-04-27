namespace GraphQL.GraphQL
{
    public class Query
    {
        private List<ContainerModel> _data = new List<ContainerModel>()
            {
                new ContainerModel() { GlobalName = "Reefer ship",Name = "Tàu chở hàng đông lạnh", Id = 1 },
                new ContainerModel() { GlobalName = "Container ship",Name = "Tàu Container", Id = 2 },
                new ContainerModel() { GlobalName = "Bulk carrier",Name = "Tàu chở hàng rời", Id = 3 },
                new ContainerModel() { GlobalName = "Ro-Ro ship",Name = "Tàu Roro", Id = 4 },
            };
        // Will return all of our todo list items
        // We are injecting the context of our dbConext to access the db
        public IQueryable<ContainerModel> GetItem()
        {
            return _data.AsQueryable();
        }
    }
    public class ContainerModel
    {
        /// <summary>
        /// Mã
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Tên tiếng việt
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Tên quốc tế
        /// </summary>
        public string? GlobalName { get; set; }
    }
}
