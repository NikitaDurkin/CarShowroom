import React, { Component, Fragment } from 'react';
import { Provider } from 'react-redux';
import { createStore, applyMiddleware } from 'redux';
import { composeWithDevTools } from 'redux-devtools-extension';
import thunk from "redux-thunk";

import Home from '../components/Header'
import About from '../components/Header'
import Users from '../components/Header'
import Header from '../components/Header';
import reducers from '../store/reducers';
import Admin from "../components/Admin";

import '../styles/index.css';

const store = createStore(reducers);
const App = () => (
    <Provider store={store}>
        <Fragment>
            <Header/>
           {/* <Admin/>*/}
        </Fragment>
    </Provider>
);
export default App;
