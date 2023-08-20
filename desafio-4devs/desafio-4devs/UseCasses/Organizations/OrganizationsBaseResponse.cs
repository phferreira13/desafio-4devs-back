namespace desafio_4devs.UseCasses.Organizations
{
    public abstract class OrganizationsBaseResponse
    {
        public required string Name { get; set; }
        public required string ContactName { get; set; }
        public string? Cnpj { get; set; }
    }
}
