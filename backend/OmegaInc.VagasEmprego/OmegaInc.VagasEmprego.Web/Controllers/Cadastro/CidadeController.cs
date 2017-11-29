using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OmegaInc.VagasEmprego.CoreData.Context;
using OmegaInc.VagasEmprego.Data.Cadastro.Endereco;
using OmegaInc.VagasEmprego.Repository.Entity.Cadastro.Endereco;
using OmegaInc.Common.Repository;
using OmegaInc.VagasEmprego.Web.AutoMapper;
using OmegaInc.VagasEmprego.Web.ViewModels.Cadastro.Endereco.Cidade;

namespace OmegaInc.VagasEmprego.Web.Controllers
{
    public class CidadeController : Controller
    {
        private IGenericRepository<Cidade, int> repo = new CidadeRepository(new DataContext());

        // GET: Cidade
        public ActionResult Index()
        {
            return View(AutoMapperManager.Instance.Mapper.Map<List<Cidade>, List<CidadeIndexViewModel>>(repo.Select()));
        }

        // GET All for jquery bootgrid
        public JsonResult GetAll(string searchPhrase, int current = 1, int rowCount = 10)
        {
            // Ordenacao
            string columnKey = Request.Form.AllKeys.Where(k => k.StartsWith("sort")).First();
            string order = Request[columnKey];
            string field = columnKey.Replace("sort[", String.Empty).Replace("]", String.Empty);

            string fieldOrdened = String.Format("{0} {1}", field, order);
            fieldOrdened = fieldOrdened.Replace("Description", String.Empty);

            List<Cidade> obj = repo.Select();

            // Pesquisa
            /* if (!String.IsNullOrWhiteSpace(searchPhrase))
             {
                 int inteiro = 0;
                 int.TryParse(searchPhrase, out inteiro);

                 List<PessoaEmpresa> pessoaEmpresa = pessoaEmpresa.Where("RazaoSocial.Contains(@0) OR NomeFantasia.Contains(@0) OR CNPJ == @1 OR InscricaoEstadual == @1", searchPhrase, inteiro).ToList();
             }*/

            List<Cidade> paginado = obj.OrderBy(fieldOrdened).Skip((current - 1) * rowCount).Take(rowCount).ToList();

            List<CidadeIndexViewModel> viewModel = AutoMapperManager.Instance.Mapper.Map<List<Cidade>, List<CidadeIndexViewModel>>(paginado);

            return Json(new
            {
                rows = viewModel,
                current = current,
                rowCount = rowCount,
                total = obj.Count()
            }, JsonRequestBehavior.AllowGet);
        }

        // GET: Cidade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade obj = repo.SelectById(id.Value);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(AutoMapperManager.Instance.Mapper.Map<Cidade, CidadeIndexViewModel>(obj));
        }

        // GET: Cidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create([Bind(Include = "Id,Descricao,Observacao")] CidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cidade obj = AutoMapperManager.Instance.Mapper.Map<CidadeViewModel, Cidade>(viewModel);
                repo.Insert(obj);

                return Json(new { resultado = true, message = "Registro criado com sucesso!" });
            }
            else
            {
                IEnumerable<ModelError> erros = ModelState.Values.SelectMany(item => item.Errors);

                return Json(new { resultado = false, message = erros });
            }
        }

        // GET: Cidade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade obj = repo.SelectById(id.Value);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(AutoMapperManager.Instance.Mapper.Map<Cidade, CidadeViewModel>(obj));
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Edit([Bind(Include = "Id,Descricao,Observacao")] CidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cidade obj = AutoMapperManager.Instance.Mapper.Map<CidadeViewModel, Cidade>(viewModel);
                repo.Edit(obj);

                return Json(new { resultado = true, message = "Registro atualizado com sucesso!" });
            }
            else
            {
                IEnumerable<ModelError> erros = ModelState.Values.SelectMany(item => item.Errors);

                return Json(new { resultado = false, message = erros });
            }
        }

        // GET: Cidade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade obj = repo.SelectById(id.Value);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(AutoMapperManager.Instance.Mapper.Map<Cidade, CidadeIndexViewModel>(obj));
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public JsonResult DeleteConfirmed(int id)
        {
            try
            {
                repo.DeleteById(id);
                return Json(new { resultado = true, message = "Registro deletado com sucesso!" });
            }
            catch (Exception e)
            {
                return Json(new { resultado = false, message = e.Message });
            }
        }

    }
}
