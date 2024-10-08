﻿using Planner.IRepository;
using Planner.Models.Enum;
using Planner.Models;

namespace Planner.Service
{
    public class TarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        //virtual: permite que o método seja substituído por uma classe derivada, para testes
        public virtual async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            return await _tarefaRepository.GetByIdAsync(id);
        }

        public virtual async Task<IEnumerable<Tarefa>> GetAllTarefasAsync()
        {
            return await _tarefaRepository.GetAllAsync();
        }

        public virtual async Task<IEnumerable<Tarefa>> GetTarefasByCategoriaAsync(Categoria categoria)
        {
            return await _tarefaRepository.GetByCategoriaAsync(categoria);
        }

        public virtual async Task<IEnumerable<Tarefa>> GetTarefasByStatusAsync(StatusTarefa status)
        {
            return await _tarefaRepository.GetByStatusAsync(status);
        }

        public virtual async Task<IEnumerable<Tarefa>> GetTarefasByCategoriaAndStatusAsync( StatusTarefa status, Categoria categoria)
        {
            return await _tarefaRepository.GetTarefasByCategoriaAndStatusAsync(status, categoria);
        }

        public virtual async Task AddTarefaAsync(Tarefa tarefa)
        {
            await _tarefaRepository.AddAsync(tarefa);
        }

        public virtual async Task UpdateTarefaAsync(Tarefa tarefa)
        {
            await _tarefaRepository.UpdateAsync(tarefa);
        }

        public virtual async Task DeleteTarefaAsync(int id)
        {
            await _tarefaRepository.DeleteAsync(id);
        }

        public virtual async Task DeleteAllTarefasAsync()
        {
            await _tarefaRepository.DeleteAllAsync();
        }
    }
}
