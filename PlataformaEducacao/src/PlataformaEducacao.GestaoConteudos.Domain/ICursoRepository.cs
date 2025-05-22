﻿using PlataformaEducacao.Core.Data;

namespace PlataformaEducacao.GestaoConteudos.Domain;

public interface ICursoRepository : IRepository<Curso>
{
    void Adicionar(Curso curso);

    Task<Curso?> ObterCursoPorAulaId(Guid aulaId);
    Task<Curso?> ObterPorId(Guid cursoId);

    Task<IEnumerable<Curso>> ObterTodos();
    Task<Aula?> ObterAulaPorId(Guid aulaId);

    Task<IEnumerable<Aula>> ObterAulasComProgressoFiltradoAluno(Guid cursoId, Guid alunoId);
    
    void Adicionar(Aula aula);
}