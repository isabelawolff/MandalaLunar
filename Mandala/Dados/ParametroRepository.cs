using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Mandala.Models;
using MongoDB.Driver;

namespace Mandala.Dados
{
    public class ParametroRepository
    {

        private const string NOME_BASE_MANDALA = "mandala";
        IMongoClient clienteMongoDB;
        IMongoDatabase baseParametros;
        IMongoCollection<DiaMandala> parametros;

        public ParametroRepository()
        {
            this.clienteMongoDB = new MongoClient("mongodb://127.0.0.1:27017");

            baseParametros = clienteMongoDB.GetDatabase(NOME_BASE_MANDALA);

            parametros = baseParametros.GetCollection<DiaMandala>(nameof(DiaMandala));

            if (parametros == null)
            {
                baseParametros.CreateCollection(nameof(DiaMandala));

                parametros = baseParametros.GetCollection<DiaMandala>(nameof(DiaMandala));
            }
        }

        public void DeleteParametro(string id)
        {
            parametros.DeleteOneAsync(Builders<DiaMandala>.Filter.Eq(a => a.Id, id));
        }

        public DiaMandala ReadParametro(string id)
        {
            return parametros.Find(Builders<DiaMandala>.Filter.Eq(a => a.Id, id)).FirstOrDefault();
        }

        public List<DiaMandala> ReadParametros()
        {
            return parametros.Find(Builders<DiaMandala>.Filter.Empty).ToList();
        }

        public void CreateParametro(DiaMandala parametro)
        {
            parametros.InsertOne(parametro);
        }
        
        public void UpdateParametro(DiaMandala parametro)
        {
            parametros.FindOneAndReplace(Builders<DiaMandala>.Filter.Eq(a => a.Id, parametro.Id), parametro);
        }

        public List<DiaMandala> ReadParametrosDoMes(string mes)
        {
            return parametros.FindSync(Builders<DiaMandala>.Filter.Eq(a => a.Mes, mes)).ToList();
        }

    }
}