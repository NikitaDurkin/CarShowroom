import React from "react";

import ListItemCar from "../ListItemCar";

const ListCar = ({ data }) => {
    return (
        <div>
            {data.map(item => {
                const { registryNumber, ...itemProps } = item;
                return(
                    <>
                        <ListItemCar
                            {...itemProps}
                            key={registryNumber}
                        />
                    </>
                );
            })}
        </div>
    );
};
export default ListCar;
