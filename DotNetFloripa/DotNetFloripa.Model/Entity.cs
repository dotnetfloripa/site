namespace DotNetFloripa.Model {
    public abstract class Entity 
    {
        public int Id { get; set; }
        public override int GetHashCode() 
        {
            if (Id == 0) {
                return base.GetHashCode();
            }
            var hashCode = 0;
            hashCode = hashCode ^ Id.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            var toCompare = obj as Entity;
            return toCompare != null && GetHashCode().Equals(toCompare.GetHashCode());
        }
    }
}
