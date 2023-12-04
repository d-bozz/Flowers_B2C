﻿using Flowers.DTO;

namespace Flowers.WebAssembly.Services.Contract
{
    public interface ICategoriaService
    {
        Task<ResponseDTO<List<CategoriaDTO>>> List(string buscar);
        Task<ResponseDTO<CategoriaDTO>> Get(int id);
        Task<ResponseDTO<CategoriaDTO>> Create(CategoriaDTO model);
        Task<ResponseDTO<bool>> Edit(CategoriaDTO model);
        Task<ResponseDTO<bool>> Delete(int id);
    }
}
