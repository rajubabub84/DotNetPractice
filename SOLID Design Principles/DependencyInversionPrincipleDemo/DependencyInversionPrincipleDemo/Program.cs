using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;
       // private readonly DataAccessLayer DAL;
        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
           // DAL = new DataAccessLayer();
        }
        public void Save(Object deatils)
        {
            DAL.Save(deatils);
        }
    }
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }
    public class DataAccessLayer:IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
    //public class BusinessLogicLayer
    //{
    //    private readonly DataAccessLayer DAL;
    //    public BusinessLogicLayer()
    //    {
    //        DAL = new DataAccessLayer();
    //    }
    //    public void Save(Object deatils)
    //    {
    //        DAL.Save(deatils);
    //    }
    //}
    //public class DataAccessLayer
    //{
    //    public void Save(Object details)
    //    {
    //        //perform save
    //    }
    //}
}
