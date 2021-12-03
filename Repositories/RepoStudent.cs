using System;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using StudentAPI.Models;
namespace StudentAPI.Repositories
{
    class StudentRepository : IStudentRepository
    {
        public ICommon Create(Student t)
        {
            ICommon retVal = new Common();
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Insert(t);
                    retVal.SetSuccess<Student>(Messages.SAVE_SUCCESS);
                }
            }
            catch (Exception ex)
            {
                retVal.SetError<Student>(Messages.SAVE_ERR);
                throw new StudentAPIException(ex.Message, ex.InnerException);
            }
            return retVal;
        }

       
        public StudentList GetList()
        {
            StudentList retVal = new StudentList();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    retVal.Students.AddRange(con.GetAll<Student>());
                }
                retVal.SetSuccess(string.Empty);
            }
            catch (Exception ex)
            {
                retVal.SetError<Student>(Messages.RETRIEVE_ERR);
                throw new StudentAPIException(ex.Message, ex.InnerException);
            }
            return retVal;
        }

        public ICommon Update(Student t)
        {
            ICommon retVal = new Common();
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Update(t);
                    retVal.SetSuccess<Student>(Messages.SAVE_SUCCESS);
                }
            }
            catch (Exception ex)
            {
                retVal.SetError<Student>(Messages.UPDATE_ERR);
                throw new StudentAPIException(ex.Message, ex.InnerException);
            }
            return retVal;
        }

        public ICommon Delete(Student t)
        {
            ICommon retVal = new Common();
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Insert(t);
                    retVal.SetSuccess<Student>(Messages.SAVE_SUCCESS);
                }
            }
            catch (Exception ex)
            {
                retVal.SetError(Messages.GEN_ERROR);
                throw new StudentAPIException(ex.Message, ex.InnerException);
            }
            return retVal;
        }

    }
}