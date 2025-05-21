import { Options } from "./Explorer"

// The nameOrderMap const do not need to be imported here.
// It is located in ./content/web-order.ts,
// and imported in quartz/components/scripts/explorer.inline.ts

import { nameOrderMap } from "../../content/web-order"


export const filterFn: Options["filterFn"] = (node) => {	
    return node.slug?.startsWith("solutions") !== true
}

export const sortFn: Options["sortFn"] = (a, b) => {
    let orderA = 0
    let orderB = 0
    orderA = nameOrderMap[a.data.filePath] || 0
    orderB = nameOrderMap[b.data.filePath] || 0
    return orderA - orderB
}
