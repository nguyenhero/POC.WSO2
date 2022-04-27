namespace GraphQL.GraphQL
{
    public class Query
    {
        private List<ContainerModel> _data = new List<ContainerModel>()
            {
                new ContainerModel() { GlobalName = "Container 1",Name = "Container 1", Id = 1 },
                new ContainerModel() { GlobalName = "Container 2",Name = "Container 2", Id = 2 },
                new ContainerModel() { GlobalName = "Container 3",Name = "Container 3", Id = 3 },
                new ContainerModel() { GlobalName = "Container 4",Name = "Container 4", Id = 4 },
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
