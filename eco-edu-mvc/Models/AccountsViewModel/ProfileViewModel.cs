﻿using eco_edu_mvc.Models.Entities;
using System.Reflection.Metadata.Ecma335;

namespace eco_edu_mvc.Models.AccountsViewModel;

public class ProfileViewModel
{
    public string Username { get; set; }
    public string FullName { get; set; }
    public string User_Code { get; set; }
    public string Entry_Date { get; set; }
    public string Email { get; set; }
    public string Section { get; set; }
    public string Class { get; set; }
    public string Citizen_Id { get; set; }
    public string Images { get; set; }
    public DateTime? CreateDate { get; set; }
    public bool? Email_Verify { get; set; }
	public List<Seminar> Seminars { get; set; }
	public List<Competition> Competitions { get; set; }
	public List<Survey> Surveys { get; set; }
}
