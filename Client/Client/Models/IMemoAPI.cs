using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public interface IMemoAPI
    {
        [Post("/Account/Register")]
        Task Register(string email, string password, [Header("Authorization")] string token);


        [Post("/Account/Login")]
        Task<LoginResponce> Login(string login, string password);


        [Post("/Account/seed")]
        Task Seed();


        [Post("/Memo")]
        Task<MemoResponse> CreateMemo([Body] CreateMemoReqest memo, [Header("Authorization")] string token);


        [Put("/Memo")]
        Task<MemoResponse> UpdateMemo([Body] UpdateMemoReqest memo, [Header("Authorization")] string token);


        [Delete("/Memo/{id}")]
        Task DeleteMemo([AliasAs("id")] int id, [Header("Authorization")] string token);


        [Get("/Memo/{id}")]
        Task<MemoResponse> GetMemo([AliasAs("id")] int id, [Header("Authorization")] string token);       


        [Get("/Memo/all")]
        Task<List<MemoResponse>> GetAllMemos([Header("Authorization")] string token);


        [Get("/Memo/find/lecturesHours?from={fromParam}&to={toParam}")]
        Task<List<MemoResponse>> GetMemosRange([AliasAs("fromParam")] int from, [AliasAs("toParam")]int to, [Header("Authorization")] string token);



        [Post("/Subjects")]
        Task AddSubject(string subjectName, [Header("Authorization")] string token);


        [Get("/Subjects")]
        Task<List<Subject>> GetSubjects();


        [Delete("/Subjects/{subjectName}")]
        Task DeleteSubject([AliasAs("subjectName")] string subjectName, [Header("Authorization")] string token);

        [Get("/Reports")]
        Task<Report> GetReports([Header("Authorization")] string token);
        
        [Get("/Reports/all")]
        Task<Report> GetAllReports([Header("Authorization")] string token);
    }
}
