import React, { Component } from 'react';
import { HashRouter as Router, Route, Switch } from 'react-router-dom';
import Desk from './components/Desk'
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import ProductsPage from './components/products';
import GalleryPage from './components/gallery/GalleryPage';
import Register from './components/views/SignUp';

const loading = () => <div>Loading...</div>;

// Pages
const desk = React.lazy(() => import('./components/Desk'));


class App extends Component {

  render() {
    return (
      <Router>
          <React.Suspense fallback={loading()}>
              <Switch>
                                    
                  <Route path="/desk" name="Desk" render={props => <Desk {...props} />} />                
              </Switch>
              </React.Suspense>
    </Router>
  );
}
}
export default App;
