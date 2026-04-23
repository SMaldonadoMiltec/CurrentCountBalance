using CurrentAccountBalance_Mark1.Models;
using SQLite;

namespace CurrentAccountBalance_Mark1.Helpers
{
    public class SqLiteDatabaseHelper
    {
        private readonly SQLiteAsyncConnection _conn;

        public SqLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Divida>().Wait();
        }

        public Task<int> InsertDivida(Divida divida)
        {
            return _conn.InsertAsync(divida);
        }

        public Task<int> UpdateDivida(Divida divida)
        {
            return _conn.UpdateAsync(divida);
        }

        public async Task<int> DeleteDivida(int id)
        {
            Divida divida = await _conn.Table<Divida>().Where(x => x.id == id).FirstOrDefaultAsync();
            if (divida == null) return 0;
            return await _conn.DeleteAsync(divida);
        }

        public Task<Divida> GetDivida(int id)
        {
            return _conn.Table<Divida>().Where(x => x.id == id).FirstOrDefaultAsync();
        }

        public Task<List<Divida>> GetDividaList()
        {
            return _conn.Table<Divida>().ToListAsync();
        }

        public Task<List<Divida>> GetDividaByName(string name)
        {
            return _conn.Table<Divida>().Where(x => x.nome.Contains(name)).ToListAsync();
        }
    }

}
