using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class MemberController : Controller
    {
       
        public static List<Member> _listMember = new List<Member>
            {
                new Member
                {
                    FirstName = "Thanh",
                    LastName = "Le",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-30),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                 new Member
                {
                    FirstName = "Tung",
                    LastName = "Vu",
                    BirthPlace = "Bac Ninh",
                    DoB = DateTime.Now.AddYears(-24),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                  new Member
                {
                    FirstName = "Thao",
                    LastName = "Vu",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-26),
                    Gender = "Female",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                   new Member
                {
                    FirstName = "Thang",
                    LastName = "Nguyen",
                    BirthPlace = "Da Nang",
                    DoB = DateTime.Now.AddYears(-15),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                    new Member
                {
                    FirstName = "Phuong",
                    LastName = "Nguyen",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-20),
                    Gender = "Female",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
            };
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member mem){
            _listMember.Add(mem);
            return RedirectToAction("Details");
        }
        public IActionResult Details(){

                                                           
            return View(_listMember);
        }
        public IActionResult Edit(string firstname,string lastname){
            Member mem = _listMember.SingleOrDefault(item=> item.FirstName == firstname && item.LastName == lastname);
            return View(mem);
        }
        [HttpPost]
        
        [HttpPost]
        public IActionResult Find(string keyword){
            if(keyword==null){
                return RedirectToAction("Details");
            }
            var check = _listMember.Where(item => item.FirstName.Contains(keyword));
            return View(check);
        }
        
    }
}