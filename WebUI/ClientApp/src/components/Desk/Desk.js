import React, { Component } from 'react';
import Select from 'react-select';
//import { Link } from 'react-router-dom';
import { Row,Fade,CardHeader,FormGroup,InputGroupButtonDropdown,
  DropdownToggle,DropdownMenu,CardFooter,DropdownItem,Button, 
  Card, CardBody, Col, Container, Form, Input, InputGroup} from 'reactstrap';
import get from "lodash.get";
import * as getListActions from './reducer';
import { connect } from 'react-redux';
import './style.scss';
import '../pages/Home/instruments/scss/palette.scss';
//import Paginator from '../Paginator';
//import Header from '../pages/Home/NavBar';
//import Footer from '../pages/Home/Footer';
import { logout } from '../pages/login/reducer';
import './Desk.css';
import { serverUrl } from "../../config";