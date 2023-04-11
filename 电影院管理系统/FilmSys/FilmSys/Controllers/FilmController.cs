using FilmSys.Models;
using FilmSys.Models.EF;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FilmSys.Controllers
{
    public class FilmController : Controller
    {
        FilmDbContext db ;
        public Admin admin = null;//判断是否登录
        public FilmController(FilmDbContext db_)
        {
            db = db_;
        }

        #region 登录界面
        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        } 
        #endregion

        #region 添加电影
        /// <summary>
        /// 添加电影
        /// </summary>
        /// <param name="Filmid"></param>
        /// <param name="Fname"></param>
        /// <param name="id"></param>
        /// <param name="Money"></param>
        /// <param name="KSTime"></param>
        /// <param name="JSTime"></param>
        /// <param name="FilmTid"></param>
        /// <param name="Remark"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddFilm(string Filmid, string Fname, string id, string Money,
            string KSTime, string JSTime, string FilmTid, string Remark)
        {
            Film f = new Film()
            {
                Filmid = Filmid,
                Fname = Fname,
                id = id,
                Money = Convert.ToDouble(Money),
                KSTime = KSTime,
                JSTime = JSTime,
                FilmTid = FilmTid,
                Remark = Remark
            };
            db.Films.Add(f);
            int n = db.SaveChanges();
            if (n > 0)
            {
                return View("First", admin);
            }
            else
            {
                return View("Error", "添加电影失败");
            }
        }
        #endregion

        #region 修改电影
        /// <summary>
        /// 修改电影
        /// </summary>
        /// <param name="Filmid"></param>
        /// <param name="Fname"></param>
        /// <param name="id"></param>
        /// <param name="Money"></param>
        /// <param name="KSTime"></param>
        /// <param name="JSTime"></param>
        /// <param name="FilmTid"></param>
        /// <param name="Remark"></param>
        /// <returns></returns>
        public IActionResult UpFilm(string Filmid, string Fname, string id, string Money,
            string KSTime, string JSTime, string FilmTid, string Remark)
        {
            Film f = new Film()
            {
                Filmid = Filmid,
                Fname = Fname,
                id = id,
                Money = Convert.ToDouble(Money),
                KSTime = KSTime,
                JSTime = JSTime,
                FilmTid = FilmTid,
                Remark = Remark
            };
            db.Films.Update(f);
            int n = db.SaveChanges();
            if (n > 0)
            {
                return View("First", admin);
            }
            else
            {
                return View("Error", "修改电影失败");
            }
        } 
        #endregion

        #region 删除电影
        /// <summary>
        /// 删除电影
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelFilm()
        {
            string id = Request.Query["id"].ToString();
            foreach (var film in db.Films)
            {
                if (film.Filmid == id)
                {
                    db.Films.Remove(film);
                    
                }
            }
            int n = db.SaveChanges();
            if (n > 0)
            {
                return View("First", admin);
            }
            else
            {
                return View("Error", "删除电影失败");
            }
        }
        #endregion

        #region 添加电影厅
        /// <summary>
        /// 添加电影厅
        /// </summary>
        /// <param name="Tid"></param>
        /// <param name="TName"></param>
        /// <param name="Number"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddFilmT(string Tid, string TName, string Number, string State)
        {
            FilmT f = new FilmT()
            {
                Tid = Tid,
                TName = TName,
                Number = Number,
                State = State,
            };
            db.FilmTs.Add(f);
            int n = db.SaveChanges();
            if (n > 0)
            {
                return View("First", admin);
            }
            else
            {
                return View("Error", "添加电影厅失败");
            }
        }
        #endregion

        #region 首页
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult First(string user, string pwd)
        {
            foreach (var ad in db.Admins)
            {
                if (ad.Login == user)
                {
                    if (ad.Password == pwd)
                    {
                        admin = ad;
                        return View(ad);
                    }
                    else
                    {
                        return View("Login", "密码错误");
                    }
                }
            }
            return View();
        }
        #endregion

        #region 电影管理界面
        /// <summary>
        /// 电影管理界面
        /// </summary>
        /// <returns></returns>
        public IActionResult FilmMain()
        {
            List<Film> films = new List<Film>();
            foreach (var film in db.Films)
            {
                films.Add(film);
            }
            return View("FilmMain", films);
        } 
        #endregion

        #region 电影厅管理界面
        /// <summary>
        /// 电影厅管理界面
        /// </summary>
        /// <returns></returns>
        public IActionResult FilmT()
        {
            List<FilmT> films = new List<FilmT>();
            foreach (var film in db.FilmTs)
            {
                films.Add(film);
            }
            return View("FilmT", films);
        }
        #endregion

        #region 错误
        /// <summary>
        /// 错误
        /// </summary>
        /// <returns></returns>
        public IActionResult Error()
        {
            return View();
        } 
        #endregion
    }
}