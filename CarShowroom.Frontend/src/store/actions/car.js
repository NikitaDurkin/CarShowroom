export const GET_CARS = 'GET_CARS';
export const GET_ASYNC_CARS = 'GET_ASYNC_CARS';

export const getCars = cars => ({
    type: GET_CARS,
    payload: cars,
})

export const asyncGetCar = (dispatch) => {
   /* console.log('GET_ASYNC_CARS');*/
    return () => {
        setTimeout(() => {
            console.log('GET_ASYNC_CARS');
            dispatch({ type: GET_ASYNC_CARS })
        }, 0)
    }
}
