namespace LoanRecovery.Interfaces
{
    public interface _IAbsGenericRepo<MainEntity, PKType>
        where MainEntity : class
    {
        public IQueryable<MainEntity> GetList();

        public Task<MainEntity> GetDetails(PKType id);

        public Task<MainEntity> Create(MainEntity table);

        public Task<MainEntity> Update(PKType id, MainEntity table);

        public Task<MainEntity> Delete(PKType id);
    }
}
