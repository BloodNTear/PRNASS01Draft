using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDBContext : BaseDAL
    {
        private static MemberDBContext instance = null;
        private static readonly object instanceLock = new object();
        private MemberDBContext() { }
        public static MemberDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MemberObject> GetMemberLists()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members";
            var members = new List<MemberObject>();

            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                    while (dataReader.Read())
                    {
                        members.Add(new MemberObject
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5)
                        });
                    }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataReader.Close();
                CloseConnection();
            }
            
            return members;
        }

        public MemberObject GetMemberByID(int id)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, id, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataReader.Close();
                CloseConnection();
            }

            return member;
        }

        public void AddMember(MemberObject member)
        {
            //try
            //{
            //    MemberObject flag = GetMemberByID(member.MemberID);
            //    if (flag == null)
            //    {
            //        string SQLInsert = "INSERT into "
            //                           + "Members values ("
            //                           + "@MemberID, "
            //                           + "@MemberName, "
            //                           + "@Email, "
            //                           + "@Password, "
            //                           + "@City, "
            //                           + "@Country)";
            //        var parameters = new List<SqlParameter>();
            //        parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
            //        parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
            //        parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
            //        parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
            //        parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));
            //    }
            //    else
            //    {
            //        throw new Exception("This Member has already exist !");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            //finally
            //{
            //    CloseConnection();
            //}

            try
            {
                string SQLInsert = "INSERT into "
                                   + "Members values ("
                                   + "@MemberID, "
                                   + "@MemberName, "
                                   + "@Email, "
                                   + "@Password, "
                                   + "@City, "
                                   + "@Country)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));

                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
            
        }

        public void UpdateMember(MemberObject member)
        {
            try
            {
                MemberObject flag = GetMemberByID(member.MemberID);
                if(flag != null)
                {
                    string SqlUpdate = "UPDATE Members set "
                                       //+ "MemberID = @MemberID, "
                                       + "MemberName = @MemberName, "
                                       + "Email = @Email, "
                                       + "Password = @Password, "
                                       + "City = @City, "
                                       + "Country = @Country "
                                       + "WHERE "
                                       + "MemberID = @MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));

                    dataProvider.Insert(SqlUpdate, CommandType.Text, parameters.ToArray());
                } else
                {
                    throw new Exception("Update Failed: The Member is not exist!");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
        }

        public void RemoveMember(int memberID)
        {
            try
            {
                MemberObject member = GetMemberByID(memberID);
                if(member != null) {
                    string SQLDelete = "DELETE FROM Members "
                                     + "WHERE "
                                     + "MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);

                }else
                {
                    throw new Exception("Delete Failed: The Member is not exist");
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
        }

        public bool Login(string Email, string Password)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "Email = @Email "
                                + "AND "
                                + "Password = @Password";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@Email", 100, Email, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@Password", 100, Email, DbType.Int32));

                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }

                if(member != null)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }
    }
}
