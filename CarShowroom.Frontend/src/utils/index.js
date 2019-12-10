import axios from 'axios';
import { URL } from '../constants';

export const getCars = axios.get(`${URL}/CarShowroom/Car/GetAll`);
export const createCar = values => axios.post(`${URL}/CarShowroom/Car`, values);

export default [
    {
        id: 1,
        mark: 'soul',
        producer: 'kia',
        color: 'white',
        price: '800 000',
        year: '2018',
    },
    {
        id: 2,
        mark: 'fabia',
        producer: 'skoda',
        color: 'black',
        price: '370 000',
        year: '2014',
    }
]
