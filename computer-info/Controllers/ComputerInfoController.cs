using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using computer_info.Models.DAO;
using computer_info.Models;
using computer_info.Models.ViewModel;


namespace SFMS.Controllers
{
    public class ComputerInfoController : Controller
    {
        private readonly ApplicationDBContext _applicationDbcontent;
        //Constructore injection
        public ComputerInfoController(ApplicationDBContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }


        public IActionResult List()
        {
            IList<ComputerInfoViewModel> computerinfos = _applicationDbcontent.ComputerInfos.Select
                      (c => new ComputerInfoViewModel
                      {
                          Id = c.Id,
                          LevelName = c.LevelName,
                          Type = c.Type,
                          Brand = c.Brand,
                          CPU = c.CPU,
                          RAM = c.RAM,
                          StorageSize = c.StorageSize,
                          isActive = c.isActive,
                          isSSD = c.isSSD,
                          CreatedAt = c.CreatedAt,
                          CreatedUserId = c.CreatedUserId,
                          UpdatedAt = c.UpdatedAt,
                          UpdatedUserId = c.UpdatedUserId
                      }).ToList();
            return View(computerinfos);
        }

        [HttpPost]
        public  IActionResult Entry(ComputerInfoViewModel computerInfoViewModel)
        {
            bool isSuccess = false;
            try
            {
               
                //creating the student record 
                ComputerInfo computerinfo = new ComputerInfo();
                //audit columns
                computerinfo.Id = Guid.NewGuid().ToString();
                computerinfo.LevelName = computerInfoViewModel.LevelName;

                computerinfo.Type = computerInfoViewModel.Type ;

                computerinfo.Brand = computerInfoViewModel.Brand;

                computerinfo.CPU = computerInfoViewModel.CPU;


                computerinfo.RAM = computerInfoViewModel.RAM;

                computerinfo.StorageSize = computerInfoViewModel.StorageSize;

                computerinfo.isActive = computerInfoViewModel.isActive;

                computerinfo.isSSD = computerInfoViewModel.isSSD;

                computerinfo.CreatedAt = DateTime.Now;
                computerinfo.UpdatedAt = DateTime.Now;

                computerinfo.CreatedUserId = Guid.NewGuid().ToString();

                computerinfo.UpdatedUserId = Guid.NewGuid().ToString();
                _applicationDbcontent.ComputerInfos.Add(computerinfo);//Adding the record Students DBSet
                _applicationDbcontent.SaveChanges();//saving the record to the database
                TempData["msg"] = "Saving success for " + computerInfoViewModel.Id + ".";
            }
            catch (Exception ex)
            {

            }
            if (isSuccess)
            {
                ViewBag.msg = "Success";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return RedirectToAction("List");
        }


        // ko pine yay
        //public IActionResult List()
        //{
        //    // Ask Ko Kyaing why i cant use Where method instead of select method
        //   










        //IList<StudentViewModel> students = _applicationDbcontent.Students.Where(s => s.FatherName == "U Ba").sel; new StudentViewModel
        //{
        //    Address = s.Address,
        //    Name = s.Name
        //}).ToList();
        //    return View(students);



        public IActionResult Delete(string id)
        {
            ComputerInfo computerInfo = _applicationDbcontent.ComputerInfos.Find(id);
            if (computerInfo != null)
            {
                _applicationDbcontent.ComputerInfos.Remove(computerInfo);//remove the  student record from DBSET
                _applicationDbcontent.SaveChanges();//remove effect to the database.
            }
            return RedirectToAction("List");
        }

        //public IActionResult Edit(string id)
        //{
        //    StudentViewModel studentViewModel = _applicationDbcontent.Students
        //        .Where(w => w.Id == id)
        //        .Select(s => new StudentViewModel
        //        {
        //            Code = s.Code,
        //            Id = s.Id,
        //            Name = s.Name,
        //            Email = s.Email,
        //            Phone = s.Phone,
        //            Address = s.Address,
        //            NRC = s.NRC,
        //            DOB = s.DOB,
        //            FatherName = s.FatherName,
        //            BatchId = s.BatchId,
        //            UserId = s.UserId
        //        }).SingleOrDefault();

        //    ViewBag.Batches = _applicationDbcontent.Batches.Select(s => new SelectListItem
        //    {
        //        Value = s.Id,
        //        Text = s.Name
        //    }).ToList();
        //    return View(studentViewModel);
        //}

        //[Authorize(Roles = "admin")]
        //[HttpPost]
        //public IActionResult Edit(StudentViewModel studentViewModel)
        //{
        //    bool isSuccess = false;
        //    try
        //    {
        //        Student student = new Student();
        //        //audit columns
        //        student.Id = studentViewModel.Id;
        //        student.ModifiedDate = DateTime.Now;
        //        student.Ip = GetLocalIPAddress();

        //        //ui columns
        //        student.Code = studentViewModel.Code;
        //        student.Name = studentViewModel.Name;
        //        student.DOB = studentViewModel.DOB;
        //        student.FatherName = studentViewModel.FatherName;
        //        student.Email = studentViewModel.Email;
        //        student.Phone = studentViewModel.Phone;
        //        student.Address = studentViewModel.Address;
        //        student.NRC = studentViewModel.NRC;
        //        student.FatherName = studentViewModel.FatherName;
        //        student.UserId = studentViewModel.UserId;
        //        _applicationDbcontent.Entry(student).State = EntityState.Modified;//Updating the existing records in DBSet
        //        _applicationDbcontent.SaveChanges();//Updating the records to the database
        //        isSuccess = true;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    if (isSuccess)
        //    {
        //        TempData["msg"] = "Update Success";
        //    }
        //    else
        //    {
        //        TempData["msg"] = "Error occur while updating";
        //    }
        //    return RedirectToAction("List");
        //}

        //finding 
    }
}
