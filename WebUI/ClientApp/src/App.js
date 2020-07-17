import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import ProductsPage from './components/products';
import GalleryPage from './components/gallery/GalleryPage';
import Register from './components/views/SignUp';


export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
    <Route path='/products/:page?' component={ProductsPage} />
    <Route path='/gallery' component={GalleryPage} />
    <Route path='/reg' component={Register}/>
  </Layout>
);
