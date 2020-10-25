import React, { useState } from 'react';
import MainPage from '../main-page/main-page';
import Questionary from '../questionary/questionary';

export const Content: React.FunctionComponent = () => {

    const [approved, setApproved] = useState(false);

    let content;

    if(!approved) {
        content = <MainPage setApproved={setApproved}/>
    } else {
        content = <Questionary />
    }

    

    return content;
}