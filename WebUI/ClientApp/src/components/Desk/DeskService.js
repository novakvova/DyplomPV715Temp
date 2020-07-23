import axios from "axios";
import {serverUrl} from '../../config';

export default class DeskService {
    static desk(model) {
        return axios.post(`${serverUrl}api/desk/desk`, model)
    };
}