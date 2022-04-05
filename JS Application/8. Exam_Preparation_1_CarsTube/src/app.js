import page from "../node_modules/page/page.mjs";
import { authMiddleware } from "./middlewares/authMiddleware.js";
import { renderNavigationMiddleware,renderContentMiddleware } from "./middlewares/renderMiddleware.js";
import { homeView } from "./views/homeView.js";
import { loginView } from "./views/loginView.js";
import { registerView } from "./views/registerView.js";
import { logoutView } from "./views/logoutView.js";
import { catalogView } from "./views/catalogView.js";
import { createView } from "./views/createView.js";
import { detailsView } from "./views/detailsView.js";
import { editView  } from "./views/editView.js";
import { deleteView } from "./views/deleteView.js";
import { searchView } from "./views/searchView.js";
import {myListView} from './views/myListView.js'

page(authMiddleware);
page(renderNavigationMiddleware);
page(renderContentMiddleware);


page('/',homeView);
page('/login',loginView);
page('/register',registerView);
page('/logout',logoutView);
page('/catalog',catalogView);
page('/create',createView)
page('/cars/:carId',detailsView);
page('/cars/:carId/edit',editView )
page('/cars/:carId/delete',deleteView );
page('/mylist', myListView)
page('/search',searchView)


page.start();