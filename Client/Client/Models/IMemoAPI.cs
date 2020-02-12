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
        [Get("/Memo/{id}")]
        Task<MemoResponse> GetMemo([AliasAs("id")] int id);

        [Post("/Memo")]
        Task<MemoResponse> CreateMemo([Body] CreateMemoReqest memo);

        [Put("/Memo")]
        Task<MemoResponse> UpdateMemo([Body] UpdateMemoReqest memo);

        [Delete("/Memo/{id}")]
        Task DeleteMemo([AliasAs("id")] int id);

        [Get("/Memo/all")]
        Task<List<MemoResponse>> GetAllMemos();

        [Get("/Memo/find/lecturesHours?from={fromParam}&to={toParam}")]
        Task<List<MemoResponse>> GetMemosRange([AliasAs("fromParam")] int from, [AliasAs("toParam")]int to);

        

        
    }
}
