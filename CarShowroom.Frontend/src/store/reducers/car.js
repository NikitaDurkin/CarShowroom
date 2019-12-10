import { GET_CARS, GET_ASYNC_CARS } from "../actions/car";

const initialState = {
    cars: []
}

const reducersCars = (state = initialState, action) => {

    switch (action.type) {
        case GET_CARS:
            console.log('action.payload!!!!!!!!!!!!!!', action.payload);
            return {
                ...state,
                cars: action.payload,
            }
        default: return state;
    }
}
export default reducersCars;
