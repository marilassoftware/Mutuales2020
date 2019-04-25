namespace Mutuales2020.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Mutuales2020.Web.Data;
    using Mutuales2020.Web.Data.Entities;
    using System.Linq;
    using System.Threading.Tasks;

    public class AffiliatesController : Controller
    {
        private readonly IRepository repository;

        public AffiliatesController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET: Affiliates
        public IActionResult Index()
        {
            return View(this.repository.GetAffiliates());
        }

        // GET: Affiliates/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = this.repository.GetAffiliate(id.Value);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // GET: Affiliates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affiliates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Affiliate affiliate)
        {
            if (ModelState.IsValid)
            {
                this.repository.AddAffiliate(affiliate);
                await this.repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(affiliate);
        }

        // GET: Affiliates/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = this.repository.GetAffiliate(id.Value);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // POST: Affiliates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Affiliate affiliate)
        {
            if (id != affiliate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this.repository.UpdateAffiliate(affiliate);
                    await this.repository.SaveAllAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.repository.AffiliateExists(affiliate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(affiliate);
        }

        // GET: Affiliates/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = this.repository.GetAffiliate(id.Value);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // POST: Affiliates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliate = this.repository.GetAffiliate(id);
            this.repository.RemoveAffiliate(affiliate);
            await this.repository.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
