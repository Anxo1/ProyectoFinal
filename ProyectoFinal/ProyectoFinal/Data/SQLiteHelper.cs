using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ProyectoFinal.Modelos;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath) 
        { 
            db = new SQLiteAsyncConnection(dbPath); 
            db.CreateTableAsync<Personajes>().Wait();
        }
        
        public Task<int> SavePersonajeAsync(Personajes per) 
        {
            if (per.id ==0)
            {
                return db.InsertAsync(per);
            }
            else
            {
                return null;
            }
        }
        //metodo que devuelve una lista con todos los presonajes craeados
        public Task<List<Personajes>> GetPersonajesAsyncs()
        {
            return db.Table<Personajes>().ToListAsync();
        }
        //metodo que devuleve un personaje en funcion de su Id
        public Task<Personajes> GetPersonajeByIdAync(int idPersonaje)
        {
            return db.Table<Personajes>().Where(a => a.id ==idPersonaje).FirstOrDefaultAsync();
        }

    }
}
