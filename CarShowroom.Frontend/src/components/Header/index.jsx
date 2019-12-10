import React from "react";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link
} from "react-router-dom";


import './index.css';
import Admin from "../Admin";

const Header = () => {
    return(
        <header>
            <h1>
                Информационная система автосалона
            </h1>

            <Router>
                <div>
                    <nav className="navigation">
                        <Link to="/">Автомобили</Link>
                        <Link to="/about">Пользователи</Link>
                        <Link to="/users">Заказы</Link>
                    </nav>
                    <Switch>
                        <Route path="/about">
                            <About />
                        </Route>
                        <Route path="/users">
                            <Users />
                        </Route>
                        <Route path="/">
                            <Admin/>
                        </Route>
                    </Switch>
                </div>
            </Router>
        </header>
    )
}


export function About() {
    return <h2>About</h2>;
}

export function Users() {
    return <h2>Users</h2>;
}
export default Header;
