using AutoMapper;
using OmegaInc.VagasEmprego.Data.Cadastro.Endereco;
using OmegaInc.VagasEmprego.Web.ViewModels.Cadastro.Endereco.Cidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmegaInc.VagasEmprego.Web.AutoMapper
{
    public class AutoMapperManager
    {
        private static readonly Lazy<AutoMapperManager> _instance
            = new Lazy<AutoMapperManager>(() =>
            {
                return new AutoMapperManager();
            });

        public static AutoMapperManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private MapperConfiguration _config;

        public IMapper Mapper
        {
            get
            {
                return _config.CreateMapper();
            }
        }

        private AutoMapperManager()
        {
            _config = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<Cidade, CidadeIndexViewModel>();
                cfg.CreateMap<CidadeIndexViewModel, Cidade>();

                cfg.CreateMap<Cidade, CidadeViewModel>();
                cfg.CreateMap<CidadeViewModel, Cidade>();
            }
            );

        }
    }
}