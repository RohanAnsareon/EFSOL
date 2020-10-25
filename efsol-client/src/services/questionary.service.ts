import * as Axios from 'axios';
import { environment } from '../enivronments/environment';


export const getQuestions = async () => {
    const url = environment.apiBaseUrl + '/questionary';

    return await Axios.default.get(url);
}
