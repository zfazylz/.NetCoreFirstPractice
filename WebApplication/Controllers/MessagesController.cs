﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class MessagesController : Controller
{
    public IActionResult ShowMessage(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            ViewData["Message"] = "Message is empty";
        }
        else
        {
            ViewData["Message"] = message;
        }

        return View();
    }
}