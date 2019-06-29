﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIstemaViviendas.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        public ActionResult Login()
        {
            return View();
        }

        //POST: Login
        [HttpPost]
        public ActionResult Login(int user, string pass)
        {
            Dominio.Repositorios.RepoUsuario repoU = new Dominio.Repositorios.RepoUsuario();
            Dominio.Models.Usuario u = repoU.buscarPorCi(user);
            if (u != null)
            {
                if (repoU.login(u)) //user y pass validos
                {
                    Session["User"] = user;
                    ViewBag.resultado = "Usuario valido.";
                    return Redirect("~/home/index");
                }
                else
                {
                    ViewBag.resultado = "Contraseña incorrecta";
                    return View();
                } 
            }
            else
            {
                ViewBag.resultado = "Usuario incorrecto";
                return View();
            }
        }

        // GET: Cuenta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuenta/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuenta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuenta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
