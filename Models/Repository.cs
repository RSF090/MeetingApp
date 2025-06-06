using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {

            private static List<UserInfo> _users = new ();
            static
            Repository(){
                _users.Add(new UserInfo {Id=1 ,Name="Furkan" , Email= "furkan123@gmail.com", Phone="1234567890", WillAttend=true, });
                _users.Add(new UserInfo {Id=2 ,Name="Erkan" , Email= "erkan123@gmail.com", Phone="1234537890", WillAttend=true,  });
                _users.Add(new UserInfo {Id=3 ,Name="Sunay" , Email= "sunay123@gmail.com", Phone="1232567890", WillAttend=true, });
                _users.Add(new UserInfo {Id=4 ,Name="Elif" , Email= "elif123@gmail.com", Phone="1231567890", WillAttend=false,  });
                _users.Add(new UserInfo {Id=5 ,Name="Senem" , Email= "senem123@gmail.com", Phone="1235567890", WillAttend=true, });


            }
            public static List<UserInfo> Users{
                get { return _users; }
            }
        
    
    public static void CreateUser(UserInfo user){
        user.Id=Users.Count+1;
        _users.Add(user);

    }
    public static UserInfo? GetbyId(int id){
        return _users.FirstOrDefault(user=> user.Id==id);
    }
   
    }
}