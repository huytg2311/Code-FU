using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> memberList = new List<Member>() {
            new Member { MemberID = 1, MemberName = "Le Van Quang", Email = "admin@fstore.com",
                Password = "admin@@", City = "Da Nang", Country = "Nong Son"},
            new Member { MemberID = 2, MemberName = "Nguyen Van A", Email = "admin@fstore.com",
                Password = "admin@@", City = "Da Nang", Country = "Que Son"},
            new Member { MemberID = 3, MemberName = "Tran Vna B", Email = "admin@fstore.com",
                Password = "admin@@", City = "Da Nang", Country = "Quang Nam"},
        
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance{
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }  
        }

        // get list
        public List<Member> GetAll => memberList;

        // get id
        public Member GetMemberByID(int memberID) {
            Member member = memberList.SingleOrDefault(pro => pro.MemberID == memberID);
            return member;
        }

        // insert
        public void Insert(Member member) {
            Member pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                memberList.Add(member);
            }
            else {
                throw new Exception("Member is already exist");
            }
        }

        // update
        public void Update(Member member) {
            Member m = GetMemberByID(member.MemberID);
            if (m != null)
            {
                var index = memberList.IndexOf(m);
                memberList[index] = member;
            }
            else {
                throw new Exception("Member does not already exist");
            }
        }

        // delete
        public void Remove(int MemberID) {
            Member r = GetMemberByID(MemberID);
            if (r != null)
            {
                memberList.Remove(r);
            }
            else {
                throw new Exception("Member does not already exists.");
            }
        }



    }
}
