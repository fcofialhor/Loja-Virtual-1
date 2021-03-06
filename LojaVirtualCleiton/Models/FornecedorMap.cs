﻿using FluentNHibernate.Mapping;

namespace Modelo
{
    public class FornecedorMap: ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.Nome);
        }
    }
}
