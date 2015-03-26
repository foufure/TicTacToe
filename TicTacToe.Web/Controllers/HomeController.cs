using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Core;
using TicTacToe.Web.ViewsWrappers;
using TicTacToeDBModel;

namespace TicTacToe.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewPresenter view = new ViewPresenter();
            IModel model = new TicTacToeModelAsDB();
            Presenter presenter = new Presenter(view, model);

            ViewBag.DisplayBoardGame = view.displayBoardGameForViewBag;
            ViewBag.displayGameInformationMessages = view.displayGameInformationMessagesForViewBag;
            ViewBag.displayQuitGameMessage = view.displayQuitGameMessageForViewBag;

            return View();
        }

        public ActionResult Play( uint fieldClicked )
        {
            ViewPresenter view = new ViewPresenter();
            IModel model = new TicTacToeModelAsDB();
            Presenter presenter = new Presenter(view, model);

            FieldPlayedEventArgument fieldPlayed = new FieldPlayedEventArgument();
            fieldPlayed.field = (Field)fieldClicked;

            presenter.onGameboardFieldPlayed(this, fieldPlayed);
            presenter.onSaveGame(this, new EventArgs());
                    
            ViewBag.DisplayBoardGame = ((ViewPresenter)presenter.gameView).displayBoardGameForViewBag;
            ViewBag.displayGameInformationMessages = ((ViewPresenter)presenter.gameView).displayGameInformationMessagesForViewBag;
            ViewBag.displayQuitGameMessage = ((ViewPresenter)presenter.gameView).displayQuitGameMessageForViewBag;

            return View("Index");
        }

        public ActionResult Restart()
        {
            ViewPresenter view = new ViewPresenter();
            IModel model = new TicTacToeModelAsDB();
            Presenter presenter = new Presenter(view, model);

            presenter.onRestartGame(this, new EventArgs());

            ViewBag.DisplayBoardGame = ((ViewPresenter)presenter.gameView).displayBoardGameForViewBag;
            ViewBag.displayGameInformationMessages = ((ViewPresenter)presenter.gameView).displayGameInformationMessagesForViewBag;
            ViewBag.displayQuitGameMessage = ((ViewPresenter)presenter.gameView).displayQuitGameMessageForViewBag;

            return View("Index");
        }

    }
}
